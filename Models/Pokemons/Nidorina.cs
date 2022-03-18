using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Nidorina Species to store common natural stats of all Nidorinas
	#region SpeciesNidorina
	public class SpeciesNidorina : PokemonSpecies
	{
#nullable enable
		private static SpeciesNidorina? _instance = null;
#nullable restore
        public static SpeciesNidorina Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesNidorina();
                }
                return _instance;
            }
        }

		#region SpeciesNidorina Constructor
		public SpeciesNidorina() : base(
			30,
			"Nidorina",
			0.8,
			20.0,
			70, // HPs
			62, 67, // Attack & Defense
			55, 55, // Special Attack & Defense
			56		
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
				"Scratch",
				"Cut",
				"Double-Kick",
				"Headbutt",
				"Horn-Drill",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Poison-Sting",
				"Bite",
				"Growl",
				"Water-Gun",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
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
				"Bide",
				"Skull-Bash",
				"Fury-Swipes",
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
				"Crunch",
				"Rock-Smash",
				"Flatter",
				"Facade",
				"Helping-Hand",
				"Secret-Power",
				"Poison-Fang",
				"Aerial-Ace",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Toxic-Spikes",
				"Poison-Jab",
				"Shadow-Claw",
				"Captivate",
				"Hone-Claws",
				"Venoshock",
				"Round",
				"Echoed-Voice",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Nidorina PokemonInstance Class
	#region Nidorina
	public class NidorinaInstance : PokemonInstance
	{
		#region Nidorina Constructors
		/// <summary>
		/// Nidorina Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public NidorinaInstance(string nickname, int level)
		: base(
				SpeciesNidorina.Instance, // Pokemon Species
				nickname, level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nidorina Builder only waiting for a Level
		/// </summary>
		public NidorinaInstance(int level)
		: base(
				SpeciesNidorina.Instance, // PokemonInstance Species
				"Nidorina", level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nidorina Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public NidorinaInstance() : base(
			SpeciesNidorina.Instance, // PokemonInstance Species
			Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}