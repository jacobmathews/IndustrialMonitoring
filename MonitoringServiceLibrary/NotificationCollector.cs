﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SharedLibrary;

namespace MonitoringServiceLibrary
{
    public class NotificationCollector
    {
        private Thread _runningThread;
        private bool _stopThread;
        private bool _isThreadRunning;

        public NotificationCollector()
        {
            RunningThread = new Thread(CheckNotifications);
        }

        public Thread RunningThread
        {
            get { return _runningThread; }
            set { _runningThread = value; }
        }

        private bool StopThread
        {
            get { return _stopThread; }
            set { _stopThread = value; }
        }

        public bool IsThreadRunning
        {
            get { return _isThreadRunning; }
            set { _isThreadRunning = value; }
        }

        public void Start()
        {
            if (IsThreadRunning == false)
            {
                this.StopThread = false;
                RunningThread.Start();                
            }
        }

        public void Stop()
        {
            this.StopThread = true;
        }

        private void CheckNotifications()
        {
            IsThreadRunning = true;

            while (!StopThread)
            {
                IndustrialMonitoringEntities entities = new IndustrialMonitoringEntities();
                List<NotificationItem> notificationItems = entities.NotificationItems.ToList();

                foreach (var notificationItem in notificationItems)
                {
                    entities = new IndustrialMonitoringEntities();
                    int notificationId = notificationItem.NotificationId;

                    NotificationItemsLogLatest notificationItemsLogLatest = entities.NotificationItemsLogLatests.FirstOrDefault(x => x.NotificationId == notificationId);

                    if (notificationItemsLogLatest==null)
                    {
                        notificationItemsLogLatest=new NotificationItemsLogLatest();
                        notificationItemsLogLatest.NotificationId = notificationId;
                        notificationItemsLogLatest.Value = false;
                        notificationItemsLogLatest.Time = DateTime.Now;

                        entities.NotificationItemsLogLatests.Add(notificationItemsLogLatest);
                        entities.SaveChanges();
                    }
                    else
                    {
                        ItemsLogLatest itemLogLatest =
        entities.ItemsLogLatests.FirstOrDefault(x => x.ItemId == notificationItem.ItemId);

                        double currentValue = double.Parse(itemLogLatest.Value);

                        bool hasNotification = false;
                        if (notificationItem.NotificationType == (int)NotificationType.Lower)
                        {
                            if (currentValue < notificationItem.High)
                            {
                                hasNotification = true;
                            }
                        }
                        else if (notificationItem.NotificationType == (int)NotificationType.Between)
                        {
                            if (currentValue > notificationItem.Low && currentValue < notificationItem.High)
                            {
                                hasNotification = true;
                            }
                        }
                        else if (notificationItem.NotificationType == (int)NotificationType.Higher)
                        {
                            if (currentValue > notificationItem.Low)
                            {
                                hasNotification = true;
                            }
                        }

                        if (hasNotification)
                        {
                            if (notificationItemsLogLatest.Value == false)
                            {
                                NotificationItemsLog notificationItemsLog = new NotificationItemsLog();
                                notificationItemsLog.NotificationId = notificationId;
                                notificationItemsLog.Value = true;
                                notificationItemsLog.Time = DateTime.Now;

                                entities.NotificationItemsLogs.Add(notificationItemsLog);
                                entities.SaveChanges();
                            }
                        }
                        else
                        {
                            if (notificationItemsLogLatest.Value)
                            {
                                NotificationItemsLog notificationItemsLog = new NotificationItemsLog();
                                notificationItemsLog.NotificationId = notificationId;
                                notificationItemsLog.Value = false;
                                notificationItemsLog.Time = DateTime.Now;

                                entities.NotificationItemsLogs.Add(notificationItemsLog);
                                entities.SaveChanges();
                            }
                        }


                        notificationItemsLogLatest.Value = hasNotification;
                        notificationItemsLogLatest.Time = DateTime.Now;
                        entities.SaveChanges();
                    }

                    Thread.Sleep(10);

                }

                Thread.Sleep(1000);                
            }

            IsThreadRunning = false;
        }
    }
}