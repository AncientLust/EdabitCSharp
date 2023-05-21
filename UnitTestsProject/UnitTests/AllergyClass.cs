namespace TestingProject
{
    public class AllergiesClassTests
    {

        [Test]
        public static void AllergiesClass()
        {
            var solo = new Allergies("Solo");
            var dimitri = new Allergies("Dimitri", "Cats Eggs Tomatoes");
            var sally = new Allergies("Sally", (int)(Allergies.Allergen.Pollen | Allergies.Allergen.Shellfish));
            var sniffy = new Allergies("Sniffy", 255);

            var test = 1;
            Assert.That(solo.ToString(), Is.EqualTo("Solo has no allergies!"), string.Format("Test {0} failed!", test++));
            solo.AddAllergy(Allergies.Allergen.Eggs);
            Assert.That(solo.ToString(), Is.EqualTo("Solo is allergic to Eggs."), string.Format("Test {0} failed!", test++));
            Assert.That(solo.Score, Is.EqualTo(1), string.Format("Test {0} failed!", test++));
            Assert.That(dimitri.ToString(), Is.EqualTo("Dimitri is allergic to Eggs, Tomatoes and Cats."), string.Format("Test {0} failed!", test++));
            Assert.That(dimitri.IsAllergicTo("Cats"), Is.EqualTo(true), string.Format("Test {0} failed!", test++));
            Assert.That(dimitri.Score, Is.EqualTo(145), string.Format("Test {0} failed!", test++));
            dimitri.DeleteAllergy("Tomatoes");
            dimitri.DeleteAllergy(Allergies.Allergen.Cats);
            dimitri.AddAllergy(Allergies.Allergen.Strawberries);
            Assert.That(dimitri.Score, Is.EqualTo(9), string.Format("Test {0} failed!", test++));
            Assert.That(sally.ToString(), Is.EqualTo("Sally is allergic to Shellfish and Pollen."), string.Format("Test {0} failed!", test++));
            Assert.That(sally.IsAllergicTo("Cats"), Is.EqualTo(false), string.Format("Test {0} failed!", test++));
            Assert.That(sally.Score, Is.EqualTo(68), string.Format("Test {0} failed!", test++));
            sally.AddAllergy("Tomatoes");
            Assert.That(sally.Score, Is.EqualTo(84), string.Format("Test {0} failed!", test++));
            Assert.That(sally.IsAllergicTo(Allergies.Allergen.Tomatoes), Is.EqualTo(true), string.Format("Test {0} failed!", test++));
            Assert.That(sniffy.Score, Is.EqualTo(255), string.Format("Test {0} failed!", test++));
            Assert.That(sniffy.ToString(), Is.EqualTo("Sniffy is allergic to Eggs, Peanuts, Shellfish, Strawberries, Tomatoes, Chocolate, Pollen and Cats."), string.Format("Test {0} failed!", test++));
        }
    }
}