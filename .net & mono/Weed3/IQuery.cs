﻿using Noear.Weed.Cache;
using System;
using System.Collections.Generic;

namespace Noear.Weed {
    public interface IQuery {
        long getCount();
        Object getValue();
        T getValue<T>(T def);
        T getValue<T>(T def, Action<CacheUsing, T> cacheCondition);
        T getItem<T>(T model) where T : IBinder;
        T getItem<T>(T model,Action<CacheUsing, T> cacheCondition) where T : IBinder;
        List<T> getList<T>(T model) where T : IBinder;
        List<T> getList<T>(T model,Action<CacheUsing, List<T>> cacheCondition) where T : IBinder;
        List<T> getArray<T>(String column);
        DataList getDataList();
        DataList getDataList(Action<CacheUsing, DataList> cacheCondition);
        DataItem getDataItem();
        DataItem getDataItem(Action<CacheUsing, DataList> cacheCondition);

        IQuery caching(ICacheService service);
        IQuery usingCache(bool isCache);
        IQuery usingCache(int seconds);
        IQuery cacheTag(String tag);
    }
}
