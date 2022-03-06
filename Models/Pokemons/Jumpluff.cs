using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Jumpluff Specie to store common natural stats of all Jumpluffs
	#region SpecieJumpluff
	public class SpecieJumpluff : PokemonSpecie
	{
#nullable enable
		private static SpecieJumpluff? _instance = null;
#nullable restore
        public static SpecieJumpluff Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieJumpluff();
                }
                return _instance;
            }
        }

		#region SpecieJumpluff Builder
		public SpecieJumpluff() : base(
			"Jumpluff",
			0.8,
			3.0,
			75, // HPs
			55, 70, // Attack & Defense
			55, 95, // Special Attack & Defense
			110		
		)
		{}
		#endregion
	}
	#endregion

	//Jumpluff Pokemon Class
	#region Jumpluff
	public class Jumpluff : Pokemon
	{
		#region Jumpluff Builders
		/// <summary>
		/// Jumpluff Builder waiting for a Nickname & a Level
		/// </summary>
		public Jumpluff(string nickname, int level)
		: base(
				189,
				SpecieJumpluff.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Jumpluff Builder only waiting for a Level
		/// </summary>
		public Jumpluff(int level)
		: base(
				189,
				SpecieJumpluff.Instance, // Pokemon Specie
				"Jumpluff", level,
				Grass.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Jumpluff Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Jumpluff() : base(
			189,
			SpecieJumpluff.Instance, // Pokemon Specie
			Grass.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}