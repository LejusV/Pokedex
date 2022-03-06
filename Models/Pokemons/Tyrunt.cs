using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Tyrunt Specie to store common natural stats of all Tyrunts
	#region SpecieTyrunt
	public class SpecieTyrunt : PokemonSpecie
	{
#nullable enable
		private static SpecieTyrunt? _instance = null;
#nullable restore
        public static SpecieTyrunt Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTyrunt();
                }
                return _instance;
            }
        }

		#region SpecieTyrunt Builder
		public SpecieTyrunt() : base(
			"Tyrunt",
			0.8,
			26.0,
			58, // HPs
			89, 77, // Attack & Defense
			45, 45, // Special Attack & Defense
			48		
		)
		{}
		#endregion
	}
	#endregion

	//Tyrunt Pokemon Class
	#region Tyrunt
	public class Tyrunt : Pokemon
	{
		#region Tyrunt Builders
		/// <summary>
		/// Tyrunt Builder waiting for a Nickname & a Level
		/// </summary>
		public Tyrunt(string nickname, int level)
		: base(
				696,
				SpecieTyrunt.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tyrunt Builder only waiting for a Level
		/// </summary>
		public Tyrunt(int level)
		: base(
				696,
				SpecieTyrunt.Instance, // Pokemon Specie
				"Tyrunt", level,
				Rock.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tyrunt Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Tyrunt() : base(
			696,
			SpecieTyrunt.Instance, // Pokemon Specie
			Rock.Instance, Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}