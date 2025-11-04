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

    [Fact]
    public void IfNoGameHasBeenStartedGameIsNotInProgress()
    {
      TicTacToe sut = new TicTacToe();
      Assert.Equal(sut.GameInProgress, false);
    }
}
