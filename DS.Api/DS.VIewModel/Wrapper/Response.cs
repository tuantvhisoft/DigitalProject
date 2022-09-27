﻿using System;
namespace DS.ViewModel.Wrapper
{
    public class Response<T>
    {
        public int? StatusCode { get; set; }
        public string? Message { get; set; }
        public IEnumerable<string>? Errors { get; set; }
        public T? Data { get; set; } = default;
    }
}

