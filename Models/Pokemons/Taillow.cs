using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Taillow Species to store common natural stats of all Taillows
	#region SpeciesTaillow
	public class SpeciesTaillow : PokemonSpecies
	{
#nullable enable
		private static SpeciesTaillow? _instance = null;
#nullable restore
        public static SpeciesTaillow Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesTaillow();
                }
                return _instance;
            }
        }

		#region SpeciesTaillow Constructor
		public SpeciesTaillow() : base(
			"Taillow",
			0.3,
			2.3,
			40, // HPs
			55, 30, // Attack & Defense
			30, 30, // Special Attack & Defense
			85		
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
				"Wing-Attack",
				"Whirlwind",
				"Fly",
				"Double-Edge",
				"Growl",
				"Supersonic",
				"Peck",
				"Counter",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Rage",
				"Mimic",
				"Double-Team",
				"Focus-Energy",
				"Mirror-Move",
				"Swift",
				"Sky-Attack",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Reversal",
				"Protect",
				"Mud-Slap",
				"Endure",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Heat-Wave",
				"Facade",
				"Endeavor",
				"Refresh",
				"Secret-Power",
				"Air-Cutter",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"Pluck",
				"Tailwind",
				"U-Turn",
				"Air-Slash",
				"Brave-Bird",
				"Defog",
				"Captivate",
				"Ominous-Wind",
				"Round",
				"Echoed-Voice",
				"Quick-Guard",
				"Work-Up",
				"Hurricane",
				"Boomburst",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Taillow PokemonInstance Class
	#region Taillow
	public class TaillowInstance : PokemonInstance
	{
		#region Taillow Constructors
		/// <summary>
		/// Taillow Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TaillowInstance(string nickname, int level)
		: base(
				276,
				SpeciesTaillow.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Taillow Builder only waiting for a Level
		/// </summary>
		public TaillowInstance(int level)
		: base(
				276,
				SpeciesTaillow.Instance, // PokemonInstance Species
				"Taillow", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Taillow Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Taillow() : base(
			276,
			SpeciesTaillow.Instance, // PokemonInstance Species
			Normal.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}