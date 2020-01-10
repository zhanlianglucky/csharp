using System;
using System.Collections.Generic;
using System.Text;


/// <summary>
/// 代理监听
/// </summary>
namespace csharp
{
    class View
    {
        private OnClickListener onClickListener;
        public void addOnClickListener(OnClickListener onClickListener)
        {
            this.onClickListener = onClickListener;
        }

        public void onClick()
        {
            if (onClickListener != null)
            {
                onClickListener.onClick();
            }
        }

    }

    /// <summary>
    /// 代理实现类 
    /// </summary>
    class OnViewClickListener : OnClickListener
    {
        public void onClick()
        {
            Console.WriteLine("OnViewClickListener excute!");
        }
    }


    /// <summary>
    /// 接口
    /// </summary>
    interface OnClickListener 
    {
        void onClick();
    }




}
