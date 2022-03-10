using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Qwilfish Species to store common natural stats of all Qwilfishs
	#region SpeciesQwilfish
	public class SpeciesQwilfish : PokemonSpecies
	{
#nullable enable
		private static SpeciesQwilfish? _instance = null;
#nullable restore
        public static SpeciesQwilfish Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesQwilfish();
                }
                return _instance;
            }
        }

		#region SpeciesQwilfish Constructor
		public SpeciesQwilfish() : base(
			"Qwilfish",
			0.5,
			3.9,
			65, // HPs
			95, 85, // Attack & Defense
			55, 55, // Special Attack & Defense
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
				"Swords-Dance",
				"Headbutt",
				"Tackle",
				"Take-Down",
				"Double-Edge",
				"Poison-Sting",
				"Pin-Missile",
				"Supersonic",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Thunder-Wave",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Harden",
				"Minimize",
				"Defense-Curl",
				"Haze",
				"Self-Destruct",
				"Waterfall",
				"Swift",
				"Bubble",
				"Explosion",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Sludge-Bomb",
				"Spikes",
				"Destiny-Bond",
				"Icy-Wind",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Hidden-Power",
				"Rain-Dance",
				"Shadow-Ball",
				"Whirlpool",
				"Stockpile",
				"Spit-Up",
				"Hail",
				"Facade",
				"Taunt",
				"Revenge",
				"Secret-Power",
				"Dive",
				"Astonish",
				"Signal-Beam",
				"Bounce",
				"Shock-Wave",
				"Water-Pulse",
				"Gyro-Ball",
				"Brine",
				"Natural-Gift",
				"Payback",
				"Toxic-Spikes",
				"Poison-Jab",
				"Aqua-Tail",
				"Captivate",
				"Aqua-Jet",
				"Venoshock",
				"Sludge-Wave",
				"Acid-Spray",
				"Round",
				"Scald",
				"Fell-Stinger",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Qwilfish PokemonInstance Class
	#region Qwilfish
	public class QwilfishInstance : PokemonInstance
	{
		#region Qwilfish Constructors
		/// <summary>
		/// Qwilfish Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public QwilfishInstance(string nickname, int level)
		: base(
				211,
				SpeciesQwilfish.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Qwilfish Builder only waiting for a Level
		/// </summary>
		public QwilfishInstance(int level)
		: base(
				211,
				SpeciesQwilfish.Instance, // PokemonInstance Species
				"Qwilfish", level,
				Water.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Qwilfish Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Qwilfish() : base(
			211,
			SpeciesQwilfish.Instance, // PokemonInstance Species
			Water.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}