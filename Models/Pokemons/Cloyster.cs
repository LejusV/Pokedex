using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Cloyster Species to store common natural stats of all Cloysters
	#region SpeciesCloyster
	public class SpeciesCloyster : PokemonSpecies
	{
#nullable enable
		private static SpeciesCloyster? _instance = null;
#nullable restore
        public static SpeciesCloyster Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCloyster();
                }
                return _instance;
            }
        }

		#region SpeciesCloyster Constructor
		public SpeciesCloyster() : base(
			91,
			"Cloyster",
			1.5,
			132.5,
			50, // HPs
			95, 180, // Attack & Defense
			85, 45, // Special Attack & Defense
			70		
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
				"Take-Down",
				"Double-Edge",
				"Supersonic",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Aurora-Beam",
				"Hyper-Beam",
				"Toxic",
				"Rage",
				"Teleport",
				"Mimic",
				"Double-Team",
				"Withdraw",
				"Reflect",
				"Bide",
				"Self-Destruct",
				"Clamp",
				"Swift",
				"Spike-Cannon",
				"Explosion",
				"Rest",
				"Tri-Attack",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Spikes",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Whirlpool",
				"Hail",
				"Torment",
				"Facade",
				"Secret-Power",
				"Dive",
				"Signal-Beam",
				"Iron-Defense",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Payback",
				"Toxic-Spikes",
				"Poison-Jab",
				"Giga-Impact",
				"Avalanche",
				"Captivate",
				"Round",
				"Shell-Smash",
				"Frost-Breath",
				"Icicle-Crash",
				"Confide",
				"Smart-Strike"
			};
		}
		#endregion
	}
	#endregion

	//Cloyster PokemonInstance Class
	#region Cloyster
	public class CloysterInstance : PokemonInstance
	{
		#region Cloyster Constructors
		/// <summary>
		/// Cloyster Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CloysterInstance(string nickname, int level)
		: base(
				SpeciesCloyster.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cloyster Builder only waiting for a Level
		/// </summary>
		public CloysterInstance(int level)
		: base(
				SpeciesCloyster.Instance, // PokemonInstance Species
				"Cloyster", level,
				Water.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cloyster Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public CloysterInstance() : base(
			SpeciesCloyster.Instance, // PokemonInstance Species
			Water.Instance, Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}