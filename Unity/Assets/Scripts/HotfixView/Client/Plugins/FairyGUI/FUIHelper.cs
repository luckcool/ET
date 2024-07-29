using System;
using FairyGUI;

namespace ET.Client
{
    public static class FUIHelper
    {
        #region AddListenerAsync(this GObject self, Func<ETTask> action)

        public static void AddListenerAsync(this GObject self, Func<ETTask> action)
        {
            async ETTask ClickActionAsync()
            {
                FUIEventComponent.Instance.isClicked = true;
                await action();
                FUIEventComponent.Instance.isClicked = false;
            }

            self.onClick.Set(() =>
            {
                if (FUIEventComponent.Instance.isClicked)
                {
                    return;
                }

                ClickActionAsync().Coroutine();
            });
        }
        
        public static void AddListenerAsync<P1>(this GObject self, Func<P1, ETTask> action, P1 p1)
        {
            async ETTask ClickActionAsync()
            {
                FUIEventComponent.Instance.isClicked = true;
                await action(p1);
                FUIEventComponent.Instance.isClicked = false;
            }

            self.onClick.Set(() =>
            {
                if (FUIEventComponent.Instance.isClicked)
                {
                    return;
                }

                ClickActionAsync().Coroutine();
            });
        }
        
        public static void AddListenerAsync<P1, P2>(this GObject self, Func<P1, P2, ETTask> action, P1 p1, P2 p2)
        {
            async ETTask ClickActionAsync()
            {
                FUIEventComponent.Instance.isClicked = true;
                await action(p1, p2);
                FUIEventComponent.Instance.isClicked = false;
            }

            self.onClick.Set(() =>
            {
                if (FUIEventComponent.Instance.isClicked)
                {
                    return;
                }

                ClickActionAsync().Coroutine();
            });
        }
        
        public static void AddListenerAsync<P1, P2 ,P3>(this GObject self, Func<P1, P2, P3, ETTask> action, P1 p1, P2 p2, P3 p3)
        {
            async ETTask ClickActionAsync()
            {
                FUIEventComponent.Instance.isClicked = true;
                await action(p1, p2, p3);
                FUIEventComponent.Instance.isClicked = false;
            }

            self.onClick.Set(() =>
            {
                if (FUIEventComponent.Instance.isClicked)
                {
                    return;
                }

                ClickActionAsync().Coroutine();
            });
        }

        #endregion

        #region AddListener(this GObject self, Action action)

        public static void AddListener(this GObject self, Action action)
        {
            self.onClick.Set(() =>
            {
                action?.Invoke();
            });
        }

        public static void AddListener<P1>(this GObject self, Action<P1> action, P1 p1)
        {
            self.onClick.Set(() =>
            {
                action?.Invoke(p1);
            });
        }
        
        public static void AddListener<P1, P2>(this GObject self, Action<P1, P2> action, P1 p1, P2 p2)
        {
            self.onClick.Set(() =>
            {
                action?.Invoke(p1, p2);
            });
        }
        
        public static void AddListener<P1, P2, P3>(this GObject self, Action<P1, P2, P3> action, P1 p1, P2 p2, P3 p3)
        {
            self.onClick.Set(() =>
            {
                action?.Invoke(p1, p2, p3);
            });
        }

        #endregion

        #region AddListenerAsync(this GObject self, Func<EventContext, ETTask> action)

        public static void AddListenerAsync(this GObject self, Func<EventContext, ETTask> action)
        {
            async ETTask ClickActionAsync(EventContext context)
            {
                FUIEventComponent.Instance.isClicked = true;
                await action(context);
                FUIEventComponent.Instance.isClicked = false;
            }

            self.onClick.Set((context) =>
            {
                if (FUIEventComponent.Instance.isClicked)
                {
                    return;
                }

                ClickActionAsync(context).Coroutine();
            });
        }

        public static void AddListenerAsync<P1>(this GObject self, Func<EventContext, P1, ETTask> action, P1 p1)
        {
            async ETTask ClickActionAsync(EventContext context)
            {
                FUIEventComponent.Instance.isClicked = true;
                await action(context, p1);
                FUIEventComponent.Instance.isClicked = false;
            }

            self.onClick.Set((context) =>
            {
                if (FUIEventComponent.Instance.isClicked)
                {
                    return;
                }

                ClickActionAsync(context).Coroutine();
            });
        }
        
        public static void AddListenerAsync<P1, P2>(this GObject self, Func<EventContext, P1, P2, ETTask> action, P1 p1, P2 p2)
        {
            async ETTask ClickActionAsync(EventContext context)
            {
                FUIEventComponent.Instance.isClicked = true;
                await action(context, p1, p2);
                FUIEventComponent.Instance.isClicked = false;
            }

            self.onClick.Set((context) =>
            {
                if (FUIEventComponent.Instance.isClicked)
                {
                    return;
                }

                ClickActionAsync(context).Coroutine();
            });
        }
        
        public static void AddListenerAsync<P1, P2, P3>(this GObject self, Func<EventContext, P1, P2, P3, ETTask> action, P1 p1, P2 p2, P3 p3)
        {
            async ETTask ClickActionAsync(EventContext context)
            {
                FUIEventComponent.Instance.isClicked = true;
                await action(context, p1, p2, p3);
                FUIEventComponent.Instance.isClicked = false;
            }

            self.onClick.Set((context) =>
            {
                if (FUIEventComponent.Instance.isClicked)
                {
                    return;
                }

                ClickActionAsync(context).Coroutine();
            });
        }

        #endregion

        #region AddListener(this GObject self, Action<EventContext> action)

        public static void AddListener(this GObject self, Action<EventContext> action)
        {
            self.onClick.Set((context) =>
            {
                action?.Invoke(context);
            });
        }

        public static void AddListener<P1>(this GObject self, Action<EventContext, P1> action, P1 p1)
        {
            self.onClick.Set((context) =>
            {
                action?.Invoke(context, p1);
            });
        }
        
        public static void AddListener<P1, P2>(this GObject self, Action<EventContext, P1, P2> action, P1 p1, P2 p2)
        {
            self.onClick.Set((context) =>
            {
                action?.Invoke(context, p1, p2);
            });
        }
        
        public static void AddListener<P1, P2, P3>(this GObject self, Action<EventContext, P1, P2, P3> action, P1 p1, P2 p2, P3 p3)
        {
            self.onClick.Set((context) =>
            {
                action?.Invoke(context, p1, p2, p3);
            });
        }

        #endregion
    }
}