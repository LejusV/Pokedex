using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Musharna Specie to store common natural stats of all Musharnas
	#region SpecieMusharna
	public class SpecieMusharna : PokemonSpecie
	{
#nullable enable
		private static SpecieMusharna? _instance = null;
#nullable restore
        public static SpecieMusharna Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMusharna();
                }
                return _instance;
            }
        }

		#region SpecieMusharna Builder
		public SpecieMusharna() : base(
			"Musharna",
			116, // HPs
			55, 85, // Attack & Defense
			107, 95, // Special Attack & Defense
			29			
		) {}
		#endregion
	}
	#endregion

	//Musharna Pokemon Class
	#region Musharna
	public class Musharna : Pokemon
	{
		#region Musharna Builders
		/// <summary>
		/// Musharna Builder waiting for a Nickname & a Level
		/// </summary>
		public Musharna(string nickname, int level)
		: base(
				518,
				SpecieMusharna.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Musharna Builder only waiting for a Level
		/// </summary>
		public Musharna(int level)
		: base(
				518,
				SpecieMusharna.Instance, // Pokemon Specie
				"Musharna", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Musharna Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Musharna() : base(
			518,
			SpecieMusharna.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
		#endregion
	}
	#endregion
}