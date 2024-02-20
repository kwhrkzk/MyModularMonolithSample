using MagicOnion;
using MagicOnion.Server;
using shared.modularA;

namespace modularA;

public class ModularAUsecase : ServiceBase<IModularAUsecase>, IModularAUsecase
{
    public async UnaryResult<ModularAUsecaseResult> Usecase1Async(int i, string s) => new(s, (i + i) * i);
}
