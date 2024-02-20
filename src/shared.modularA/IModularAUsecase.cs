using MagicOnion;

namespace shared.modularA;

public interface IModularAUsecase: IService<IModularAUsecase>
{
    UnaryResult<ModularAUsecaseResult> Usecase1Async(int i, string s);
}
