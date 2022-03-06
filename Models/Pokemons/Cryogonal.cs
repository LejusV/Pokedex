using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Cryogonal Specie to store common natural stats of all Cryogonals
	#region SpecieCryogonal
	public class SpecieCryogonal : PokemonSpecie
	{
#nullable enable
		private static SpecieCryogonal? _instance = null;
#nullable restore
        public static SpecieCryogonal Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCryogonal();
                }
                return _instance;
            }
        }

		#region SpecieCryogonal Builder
		public SpecieCryogonal() : base(
			"Cryogonal",
			1.1,
			148.0,
			80, // HPs
			50, 50, // Attack & Defense
			95, 135, // Special Attack & Defense
			105		
		)
		{}
		#endregion
	}
	#endregion

	//Cryogonal Pokemon Class
	#region Cryogonal
	public class Cryogonal : Pokemon
	{
		#region Cryogonal Builders
		/// <summary>
		/// Cryogonal Builder waiting for a Nickname & a Level
		/// </summary>
		public Cryogonal(string nickname, int level)
		: base(
				615,
				SpecieCryogonal.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cryogonal Builder only waiting for a Level
		/// </summary>
		public Cryogonal(int level)
		: base(
				615,
				SpecieCryogonal.Instance, // Pokemon Specie
				"Cryogonal", level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cryogonal Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Cryogonal() : base(
			615,
			SpecieCryogonal.Instance, // Pokemon Specie
			Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}