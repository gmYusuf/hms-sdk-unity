﻿namespace HuaweiMobileServices.Base
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    internal class OnSuccessListenerWrapper<T> : AndroidJavaProxy where T : JavaObjectWrapper
    {
        protected IOnSuccessListener<T> mListener;

        public OnSuccessListenerWrapper(IOnSuccessListener<T> listener) : base("com.huawei.hmf.tasks.OnSuccessListener")
        {
            mListener = listener;
        }

        public void onSuccess(AndroidJavaObject result)
        {
            mListener.OnSuccess(result.AsWrapper<T>());
        }
    }
}
