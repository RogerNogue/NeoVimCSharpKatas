using Xunit;

public class UnitTest1
{
    [Fact]
    public void TicTacToeCanBeInstantiated()
    {
      TicTacToe sut = new TicTacToe();
      Assert.NotNull(sut);
    }
}
