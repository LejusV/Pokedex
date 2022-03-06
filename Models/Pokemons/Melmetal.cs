using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Melmetal Specie to store common natural stats of all Melmetals
	#region SpecieMelmetal
	public class SpecieMelmetal : PokemonSpecie
	{
#nullable enable
		private static SpecieMelmetal? _instance = null;
#nullable restore
        public static SpecieMelmetal Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMelmetal();
                }
                return _instance;
            }
        }

		#region SpecieMelmetal Builder
		public SpecieMelmetal() : base(
			"Melmetal",
			2.5,
			800.0,
			135, // HPs
			143, 143, // Attack & Defense
			80, 65, // Special Attack & Defense
			34		
		)
		{}
		#endregion
	}
	#endregion

	//Melmetal Pokemon Class
	#region Melmetal
	public class Melmetal : Pokemon
	{
		#region Melmetal Builders
		/// <summary>
		/// Melmetal Builder waiting for a Nickname & a Level
		/// </summary>
		public Melmetal(string nickname, int level)
		: base(
				809,
				SpecieMelmetal.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Melmetal Builder only waiting for a Level
		/// </summary>
		public Melmetal(int level)
		: base(
				809,
				SpecieMelmetal.Instance, // Pokemon Specie
				"Melmetal", level,
				Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Melmetal Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Melmetal() : base(
			809,
			SpecieMelmetal.Instance, // Pokemon Specie
			Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}