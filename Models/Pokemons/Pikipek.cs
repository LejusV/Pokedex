using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Pikipek Species to store common natural stats of all Pikipeks
	#region SpeciesPikipek
	public class SpeciesPikipek : PokemonSpecies
	{
#nullable enable
		private static SpeciesPikipek? _instance = null;
#nullable restore
        public static SpeciesPikipek Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPikipek();
                }
                return _instance;
            }
        }

		#region SpeciesPikipek Constructor
		public SpeciesPikipek() : base(
			731,
			"Pikipek",
			0.3,
			1.2,
			35, // HPs
			75, 30, // Attack & Defense
			30, 30, // Special Attack & Defense
			65		
		)
		{
			InitMovesList();
		}
		#endregion

		#region Methods
		private void InitMovesList()
		{
			_moveList = new List<string>()
			{
				"Swords-Dance",
				"Fly",
				"Fury-Attack",
				"Growl",
				"Supersonic",
				"Peck",
				"Drill-Peck",
				"Toxic",
				"Screech",
				"Double-Team",
				"Mirror-Move",
				"Rest",
				"Substitute",
				"Thief",
				"Protect",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Uproar",
				"Brick-Break",
				"Feather-Dance",
				"Hyper-Voice",
				"Bullet-Seed",
				"Aerial-Ace",
				"Roost",
				"Pluck",
				"Tailwind",
				"U-Turn",
				"Brave-Bird",
				"Smack-Down",
				"Flame-Charge",
				"Round",
				"Echoed-Voice",
				"Work-Up",
				"Boomburst",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Pikipek PokemonInstance Class
	#region Pikipek
	public class PikipekInstance : PokemonInstance
	{
		#region Pikipek Constructors
		/// <summary>
		/// Pikipek Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PikipekInstance(string nickname, int level)
		: base(
				SpeciesPikipek.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pikipek Builder only waiting for a Level
		/// </summary>
		public PikipekInstance(int level)
		: base(
				SpeciesPikipek.Instance, // PokemonInstance Species
				"Pikipek", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pikipek Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public PikipekInstance() : base(
			SpeciesPikipek.Instance, // PokemonInstance Species
			Normal.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}