﻿// Decompiled with JetBrains decompiler
// Type: Owasp.Esapi.Interfaces.IAccessController
// Assembly: Owasp.Esapi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6AEE56C8-668B-47C7-A220-9A96BB995F18
// Assembly location: C:\Users\u2\Downloads\Owasp.Esapi.dll

namespace Owasp.Esapi.Interfaces
{
  public interface IAccessController
  {
    bool IsAuthorizedForUrl(string url);

    bool IsAuthorizedForFunction(string functionName);

    bool IsAuthorizedForData(string key);

    bool IsAuthorizedForFile(string filepath);

    bool IsAuthorizedForService(string serviceName);

    void AssertAuthorizedForUrl(string url);

    void AssertAuthorizedForFunction(string functionName);

    void AssertAuthorizedForData(string key);

    void AssertAuthorizedForFile(string filepath);

    void AssertAuthorizedForService(string serviceName);
  }
}
