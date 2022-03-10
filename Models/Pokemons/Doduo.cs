using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Doduo Species to store common natural stats of all Doduos
	#region SpeciesDoduo
	public class SpeciesDoduo : PokemonSpecies
	{
#nullable enable
		private static SpeciesDoduo? _instance = null;
#nullable restore
        public static SpeciesDoduo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDoduo();
                }
                return _instance;
            }
        }

		#region SpeciesDoduo Constructor
		public SpeciesDoduo() : base(
			"Doduo",
			1.4,
			39.2,
			35, // HPs
			85, 45, // Attack & Defense
			35, 35, // Special Attack & Defense
			75		
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
				"Whirlwind",
				"Fly",
				"Jump-Kick",
				"Fury-Attack",
				"Body-Slam",
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Growl",
				"Supersonic",
				"Peck",
				"Drill-Peck",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Rage",
				"Mimic",
				"Double-Team",
				"Haze",
				"Reflect",
				"Bide",
				"Mirror-Move",
				"Swift",
				"Skull-Bash",
				"Sky-Attack",
				"Rest",
				"Tri-Attack",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Feint-Attack",
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
				"Sunny-Day",
				"Uproar",
				"Facade",
				"Knock-Off",
				"Endeavor",
				"Secret-Power",
				"Air-Cutter",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"Pluck",
				"Acupressure",
				"Assurance",
				"Brave-Bird",
				"Captivate",
				"Double-Hit",
				"Round",
				"Echoed-Voice",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Doduo PokemonInstance Class
	#region Doduo
	public class DoduoInstance : PokemonInstance
	{
		#region Doduo Constructors
		/// <summary>
		/// Doduo Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DoduoInstance(string nickname, int level)
		: base(
				84,
				SpeciesDoduo.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Doduo Builder only waiting for a Level
		/// </summary>
		public DoduoInstance(int level)
		: base(
				84,
				SpeciesDoduo.Instance, // PokemonInstance Species
				"Doduo", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Doduo Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Doduo() : base(
			84,
			SpeciesDoduo.Instance, // PokemonInstance Species
			Normal.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}