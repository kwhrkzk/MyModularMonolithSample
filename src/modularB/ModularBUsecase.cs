using MagicOnion;
using MagicOnion.Server;
using shared.modularB;
using System;

namespace modularB;

public class ModularBUsecase : ServiceBase<IModularBUsecase>, IModularBUsecase
{
    public async UnaryResult<ModularBUsecaseResult> Usecase2Async(string s, int i) => new(Guid.NewGuid().ToString(), i);
}
