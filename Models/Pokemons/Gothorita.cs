using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Gothorita Specie to store common natural stats of all Gothoritas
	#region SpecieGothorita
	public class SpecieGothorita : PokemonSpecie
	{
#nullable enable
		private static SpecieGothorita? _instance = null;
#nullable restore
        public static SpecieGothorita Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGothorita();
                }
                return _instance;
            }
        }

		#region SpecieGothorita Builder
		public SpecieGothorita() : base(
			"Gothorita",
			0.7,
			18.0,
			60, // HPs
			45, 70, // Attack & Defense
			75, 85, // Special Attack & Defense
			55		
		)
		{}
		#endregion
	}
	#endregion

	//Gothorita Pokemon Class
	#region Gothorita
	public class Gothorita : Pokemon
	{
		#region Gothorita Builders
		/// <summary>
		/// Gothorita Builder waiting for a Nickname & a Level
		/// </summary>
		public Gothorita(string nickname, int level)
		: base(
				575,
				SpecieGothorita.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gothorita Builder only waiting for a Level
		/// </summary>
		public Gothorita(int level)
		: base(
				575,
				SpecieGothorita.Instance, // Pokemon Specie
				"Gothorita", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gothorita Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Gothorita() : base(
			575,
			SpecieGothorita.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}