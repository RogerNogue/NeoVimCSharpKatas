using Xunit;

public class UnitTest1
{
    [Fact]
    public void TicTacToeCanBeInstantiated()
    {
      TicTacToe sut = new TicTacToe();
      Assert.NotNull(sut);
    }

    [Fact]
    public void NewGameCanBeStarted()
    {
      TicTacToe sut = new TicTacToe();
      sut.StartGame();
      Assert.Equal(sut.GameInProgress, true);
    }
}
