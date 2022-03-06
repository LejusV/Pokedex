using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Sentret Specie to store common natural stats of all Sentrets
	#region SpecieSentret
	public class SpecieSentret : PokemonSpecie
	{
#nullable enable
		private static SpecieSentret? _instance = null;
#nullable restore
        public static SpecieSentret Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSentret();
                }
                return _instance;
            }
        }

		#region SpecieSentret Builder
		public SpecieSentret() : base(
			"Sentret",
			0.8,
			6.0,
			35, // HPs
			46, 34, // Attack & Defense
			35, 45, // Special Attack & Defense
			20		
		)
		{}
		#endregion
	}
	#endregion

	//Sentret Pokemon Class
	#region Sentret
	public class Sentret : Pokemon
	{
		#region Sentret Builders
		/// <summary>
		/// Sentret Builder waiting for a Nickname & a Level
		/// </summary>
		public Sentret(string nickname, int level)
		: base(
				161,
				SpecieSentret.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sentret Builder only waiting for a Level
		/// </summary>
		public Sentret(int level)
		: base(
				161,
				SpecieSentret.Instance, // Pokemon Specie
				"Sentret", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sentret Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Sentret() : base(
			161,
			SpecieSentret.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}