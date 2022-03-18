using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Goldeen Species to store common natural stats of all Goldeens
	#region SpeciesGoldeen
	public class SpeciesGoldeen : PokemonSpecies
	{
#nullable enable
		private static SpeciesGoldeen? _instance = null;
#nullable restore
        public static SpeciesGoldeen Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGoldeen();
                }
                return _instance;
            }
        }

		#region SpeciesGoldeen Constructor
		public SpeciesGoldeen() : base(
			118,
			"Goldeen",
			0.6,
			15.0,
			45, // HPs
			67, 60, // Attack & Defense
			35, 50, // Special Attack & Defense
			63		
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
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Supersonic",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Psybeam",
				"Bubble-Beam",
				"Peck",
				"Toxic",
				"Agility",
				"Rage",
				"Mimic",
				"Double-Team",
				"Haze",
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
				"Mud-Sport",
				"Signal-Beam",
				"Bounce",
				"Mud-Shot",
				"Water-Sport",
				"Water-Pulse",
				"Natural-Gift",
				"Aqua-Ring",
				"Poison-Jab",
				"Aqua-Tail",
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

	//Goldeen PokemonInstance Class
	#region Goldeen
	public class GoldeenInstance : PokemonInstance
	{
		#region Goldeen Constructors
		/// <summary>
		/// Goldeen Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GoldeenInstance(string nickname, int level)
		: base(
				SpeciesGoldeen.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Goldeen Builder only waiting for a Level
		/// </summary>
		public GoldeenInstance(int level)
		: base(
				SpeciesGoldeen.Instance, // PokemonInstance Species
				"Goldeen", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Goldeen Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public GoldeenInstance() : base(
			SpeciesGoldeen.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}