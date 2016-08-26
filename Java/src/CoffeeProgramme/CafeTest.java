package CoffeeProgramme;
import org.junit.*;

/**
 * Created by student on 26-Aug-16.
 */


public class CafeTest {

    public static final int NO_MILK = 0;
    public static final int NO_BEANS = 0;
    public static final int ESPRESSO_BEANS = CoffeeType.Espresso.getRequiredBeans();

    private Cafe cafe;

    // Check before testing
    @Before
    public void before() {
        cafe = new Cafe();
    }

    // Note the play button next to method
    @Test
    public void canBrewEspresso() {
        // Given
        //withBeans();
        // When
        Coffee coffee = cafe.brew(CoffeeType.FilterCoffee);
        // Then
        // 1 - is it a espresso
        Assert.assertEquals("Wrong Coffee Type.", CoffeeType.Espresso, coffee.getType());
    }

    public void withBeans() {
        cafe.restockBeans(ESPRESSO_BEANS);

    }
}
