﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDB.VisualStudio
{
    public interface IMessageBroker
    {
        void Publish<TMessage>(TMessage message);

        void Subscribe<TMessage>(Action<TMessage> callback);
    }
}