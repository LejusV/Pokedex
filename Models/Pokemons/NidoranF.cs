using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Nidoran-F Species to store common natural stats of all Nidoran-Fs
	#region SpeciesNidoran-F
	public class SpeciesNidoranF : PokemonSpecies
	{
#nullable enable
		private static SpeciesNidoranF? _instance = null;
#nullable restore
        public static SpeciesNidoranF Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesNidoranF();
                }
                return _instance;
            }
        }

		#region SpeciesNidoran-F Constructor
		public SpeciesNidoranF() : base(
			"Nidoran-F",
			0.4,
			7.0,
			55, // HPs
			47, 52, // Attack & Defense
			40, 40, // Special Attack & Defense
			41		
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
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Poison-Sting",
				"Bite",
				"Growl",
				"Supersonic",
				"Disable",
				"Ice-Beam",
				"Blizzard",
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
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Rock-Smash",
				"Beat-Up",
				"Flatter",
				"Facade",
				"Helping-Hand",
				"Secret-Power",
				"Poison-Fang",
				"Aerial-Ace",
				"Poison-Tail",
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
				"Chip-Away",
				"Confide",
				"Venom-Drench"
			};
		}
		#endregion
	}
	#endregion

	//Nidoran-F PokemonInstance Class
	#region Nidoran-F
	public class NidoranFInstance : PokemonInstance
	{
		#region Nidoran-F Constructors
		/// <summary>
		/// Nidoran-F Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public NidoranFInstance(string nickname, int level)
		: base(
				29,
				SpeciesNidoranF.Instance, // Pokemon Species
				nickname, level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nidoran-F Builder only waiting for a Level
		/// </summary>
		public NidoranFInstance(int level)
		: base(
				29,
				SpeciesNidoranF.Instance, // PokemonInstance Species
				"Nidoran-F", level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nidoran-F Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public NidoranF() : base(
			29,
			SpeciesNidoranF.Instance, // PokemonInstance Species
			Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}