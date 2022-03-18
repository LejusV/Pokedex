using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Nidorino Species to store common natural stats of all Nidorinos
	#region SpeciesNidorino
	public class SpeciesNidorino : PokemonSpecies
	{
#nullable enable
		private static SpeciesNidorino? _instance = null;
#nullable restore
        public static SpeciesNidorino Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesNidorino();
                }
                return _instance;
            }
        }

		#region SpeciesNidorino Constructor
		public SpeciesNidorino() : base(
			33,
			"Nidorino",
			0.9,
			19.5,
			61, // HPs
			72, 57, // Attack & Defense
			55, 55, // Special Attack & Defense
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
				"Cut",
				"Double-Kick",
				"Headbutt",
				"Horn-Attack",
				"Fury-Attack",
				"Horn-Drill",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Poison-Sting",
				"Leer",
				"Water-Gun",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Peck",
				"Counter",
				"Strength",
				"Thunderbolt",
				"Thunder",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Reflect",
				"Focus-Energy",
				"Bide",
				"Skull-Bash",
				"Rest",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Detect",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Flatter",
				"Facade",
				"Helping-Hand",
				"Secret-Power",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Sucker-Punch",
				"Toxic-Spikes",
				"Poison-Jab",
				"Shadow-Claw",
				"Captivate",
				"Hone-Claws",
				"Venoshock",
				"Round",
				"Echoed-Voice",
				"Drill-Run",
				"Confide",
				"Smart-Strike"
			};
		}
		#endregion
	}
	#endregion

	//Nidorino PokemonInstance Class
	#region Nidorino
	public class NidorinoInstance : PokemonInstance
	{
		#region Nidorino Constructors
		/// <summary>
		/// Nidorino Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public NidorinoInstance(string nickname, int level)
		: base(
				SpeciesNidorino.Instance, // Pokemon Species
				nickname, level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nidorino Builder only waiting for a Level
		/// </summary>
		public NidorinoInstance(int level)
		: base(
				SpeciesNidorino.Instance, // PokemonInstance Species
				"Nidorino", level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nidorino Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public NidorinoInstance() : base(
			SpeciesNidorino.Instance, // PokemonInstance Species
			Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}