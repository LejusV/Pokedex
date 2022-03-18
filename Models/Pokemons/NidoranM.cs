using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Nidoran-M Species to store common natural stats of all Nidoran-Ms
	#region SpeciesNidoran-M
	public class SpeciesNidoranM : PokemonSpecies
	{
#nullable enable
		private static SpeciesNidoranM? _instance = null;
#nullable restore
        public static SpeciesNidoranM Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesNidoranM();
                }
                return _instance;
            }
        }

		#region SpeciesNidoran-M Constructor
		public SpeciesNidoranM() : base(
			32,
			"Nidoran-M",
			0.5,
			9.0,
			46, // HPs
			57, 40, // Attack & Defense
			40, 40, // Special Attack & Defense
			50		
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
				"Supersonic",
				"Disable",
				"Ice-Beam",
				"Blizzard",
				"Peck",
				"Counter",
				"Strength",
				"Thunderbolt",
				"Thunder",
				"Dig",
				"Toxic",
				"Confusion",
				"Rage",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Reflect",
				"Focus-Energy",
				"Bide",
				"Skull-Bash",
				"Amnesia",
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
				"Beat-Up",
				"Flatter",
				"Facade",
				"Helping-Hand",
				"Secret-Power",
				"Poison-Tail",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Sucker-Punch",
				"Toxic-Spikes",
				"Poison-Jab",
				"Shadow-Claw",
				"Captivate",
				"Head-Smash",
				"Hone-Claws",
				"Venoshock",
				"Round",
				"Echoed-Voice",
				"Chip-Away",
				"Drill-Run",
				"Confide",
				"Venom-Drench",
				"Smart-Strike"
			};
		}
		#endregion
	}
	#endregion

	//Nidoran-M PokemonInstance Class
	#region Nidoran-M
	public class NidoranMInstance : PokemonInstance
	{
		#region Nidoran-M Constructors
		/// <summary>
		/// Nidoran-M Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public NidoranMInstance(string nickname, int level)
		: base(
				SpeciesNidoranM.Instance, // Pokemon Species
				nickname, level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nidoran-M Builder only waiting for a Level
		/// </summary>
		public NidoranMInstance(int level)
		: base(
				SpeciesNidoranM.Instance, // PokemonInstance Species
				"Nidoran-M", level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nidoran-M Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public NidoranMInstance() : base(
			SpeciesNidoranM.Instance, // PokemonInstance Species
			Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}