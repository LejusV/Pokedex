using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Registeel Specie to store common natural stats of all Registeels
	#region SpecieRegisteel
	public class SpecieRegisteel : PokemonSpecie
	{
#nullable enable
		private static SpecieRegisteel? _instance = null;
#nullable restore
        public static SpecieRegisteel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRegisteel();
                }
                return _instance;
            }
        }

		#region SpecieRegisteel Builder
		public SpecieRegisteel() : base(
			"Registeel",
			80, // HPs
			75, 150, // Attack & Defense
			75, 150, // Special Attack & Defense
			50			
		) {}
		#endregion
	}
	#endregion

	//Registeel Pokemon Class
	#region Registeel
	public class Registeel : Pokemon
	{
		#region Registeel Builders
		/// <summary>
		/// Registeel Builder waiting for a Nickname & a Level
		/// </summary>
		public Registeel(string nickname, int level)
		: base(
				379,
				SpecieRegisteel.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Registeel Builder only waiting for a Level
		/// </summary>
		public Registeel(int level)
		: base(
				379,
				SpecieRegisteel.Instance, // Pokemon Specie
				"Registeel", level,
				Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Registeel Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Registeel() : base(
			379,
			SpecieRegisteel.Instance, // Pokemon Specie
			Steel.Instance			
		) {}
		#endregion
	}
	#endregion
}