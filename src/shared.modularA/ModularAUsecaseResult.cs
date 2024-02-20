using MessagePack;

namespace shared.modularA;

[MessagePackObject(true)]
public record ModularAUsecaseResult(string S, int I);