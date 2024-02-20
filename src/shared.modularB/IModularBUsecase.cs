using MagicOnion;

namespace shared.modularB;

public interface IModularBUsecase: IService<IModularBUsecase>
{
    UnaryResult<ModularBUsecaseResult> Usecase2Async(string s, int i);
}
