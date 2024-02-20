using MessagePack;

namespace shared.modularB;

[MessagePackObject(true)]
public record ModularBUsecaseResult(string S, int I);