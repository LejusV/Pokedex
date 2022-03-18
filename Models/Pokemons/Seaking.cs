using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Seaking Species to store common natural stats of all Seakings
	#region SpeciesSeaking
	public class SpeciesSeaking : PokemonSpecies
	{
#nullable enable
		private static SpeciesSeaking? _instance = null;
#nullable restore
        public static SpeciesSeaking Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSeaking();
                }
                return _instance;
            }
        }

		#region SpeciesSeaking Constructor
		public SpeciesSeaking() : base(
			119,
			"Seaking",
			1.3,
			39.0,
			80, // HPs
			92, 65, // Attack & Defense
			65, 80, // Special Attack & Defense
			68		
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
				"Horn-Attack",
				"Fury-Attack",
				"Horn-Drill",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Supersonic",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Peck",
				"Toxic",
				"Agility",
				"Rage",
				"Mimic",
				"Double-Team",
				"Bide",
				"Waterfall",
				"Swift",
				"Skull-Bash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Megahorn",
				"Hidden-Power",
				"Rain-Dance",
				"Whirlpool",
				"Hail",
				"Facade",
				"Knock-Off",
				"Secret-Power",
				"Dive",
				"Signal-Beam",
				"Bounce",
				"Water-Sport",
				"Water-Pulse",
				"Natural-Gift",
				"Aqua-Ring",
				"Poison-Jab",
				"Aqua-Tail",
				"Giga-Impact",
				"Captivate",
				"Soak",
				"Round",
				"Scald",
				"Drill-Run",
				"Confide",
				"Smart-Strike"
			};
		}
		#endregion
	}
	#endregion

	//Seaking PokemonInstance Class
	#region Seaking
	public class SeakingInstance : PokemonInstance
	{
		#region Seaking Constructors
		/// <summary>
		/// Seaking Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SeakingInstance(string nickname, int level)
		: base(
				SpeciesSeaking.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Seaking Builder only waiting for a Level
		/// </summary>
		public SeakingInstance(int level)
		: base(
				SpeciesSeaking.Instance, // PokemonInstance Species
				"Seaking", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Seaking Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SeakingInstance() : base(
			SpeciesSeaking.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}