using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Kakuna Specie to store common natural stats of all Kakunas
	#region SpecieKakuna
	public class SpecieKakuna : PokemonSpecie
	{
#nullable enable
		private static SpecieKakuna? _instance = null;
#nullable restore
        public static SpecieKakuna Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKakuna();
                }
                return _instance;
            }
        }

		#region SpecieKakuna Builder
		public SpecieKakuna() : base(
			"Kakuna",
			0.6,
			10.0,
			45, // HPs
			25, 50, // Attack & Defense
			25, 25, // Special Attack & Defense
			35		
		)
		{}
		#endregion
	}
	#endregion

	//Kakuna Pokemon Class
	#region Kakuna
	public class Kakuna : Pokemon
	{
		#region Kakuna Builders
		/// <summary>
		/// Kakuna Builder waiting for a Nickname & a Level
		/// </summary>
		public Kakuna(string nickname, int level)
		: base(
				14,
				SpecieKakuna.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kakuna Builder only waiting for a Level
		/// </summary>
		public Kakuna(int level)
		: base(
				14,
				SpecieKakuna.Instance, // Pokemon Specie
				"Kakuna", level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kakuna Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Kakuna() : base(
			14,
			SpecieKakuna.Instance, // Pokemon Specie
			Bug.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}