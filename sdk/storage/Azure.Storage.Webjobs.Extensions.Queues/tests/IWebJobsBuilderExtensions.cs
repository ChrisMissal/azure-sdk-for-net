﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Storage.Queues;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.DependencyInjection;

namespace Azure.WebJobs.Extensions.Storage.Queues.Tests
{
    internal static class IWebJobsBuilderExtensions
    {
        public static IWebJobsBuilder UseQueueService(this IWebJobsBuilder builder, QueueServiceClient queueServiceClient)
        {
            builder.Services.Add(ServiceDescriptor.Singleton<QueueServiceClientProvider>(new FakeQueueServiceClientProvider(queueServiceClient)));
            return builder;
        }
    }
}
