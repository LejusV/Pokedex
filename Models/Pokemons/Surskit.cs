using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Surskit Specie to store common natural stats of all Surskits
	#region SpecieSurskit
	public class SpecieSurskit : PokemonSpecie
	{
#nullable enable
		private static SpecieSurskit? _instance = null;
#nullable restore
        public static SpecieSurskit Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSurskit();
                }
                return _instance;
            }
        }

		#region SpecieSurskit Builder
		public SpecieSurskit() : base(
			"Surskit",
			40, // HPs
			30, 32, // Attack & Defense
			50, 52, // Special Attack & Defense
			65			
		) {}
		#endregion
	}
	#endregion

	//Surskit Pokemon Class
	#region Surskit
	public class Surskit : Pokemon
	{
		#region Surskit Builders
		/// <summary>
		/// Surskit Builder waiting for a Nickname & a Level
		/// </summary>
		public Surskit(string nickname, int level)
		: base(
				283,
				SpecieSurskit.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Surskit Builder only waiting for a Level
		/// </summary>
		public Surskit(int level)
		: base(
				283,
				SpecieSurskit.Instance, // Pokemon Specie
				"Surskit", level,
				Bug.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Surskit Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Surskit() : base(
			283,
			SpecieSurskit.Instance, // Pokemon Specie
			Bug.Instance, Water.Instance			
		) {}
		#endregion
	}
	#endregion
}