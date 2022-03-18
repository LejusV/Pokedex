using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Omanyte Species to store common natural stats of all Omanytes
	#region SpeciesOmanyte
	public class SpeciesOmanyte : PokemonSpecies
	{
#nullable enable
		private static SpeciesOmanyte? _instance = null;
#nullable restore
        public static SpeciesOmanyte Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesOmanyte();
                }
                return _instance;
            }
        }

		#region SpeciesOmanyte Constructor
		public SpeciesOmanyte() : base(
			138,
			"Omanyte",
			0.4,
			7.5,
			35, // HPs
			40, 100, // Attack & Defense
			90, 55, // Special Attack & Defense
			35		
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
				"Bind",
				"Slam",
				"Headbutt",
				"Horn-Attack",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Leer",
				"Bite",
				"Supersonic",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Aurora-Beam",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Withdraw",
				"Haze",
				"Reflect",
				"Bide",
				"Waterfall",
				"Spike-Cannon",
				"Constrict",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Spikes",
				"Icy-Wind",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Ancient-Power",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Knock-Off",
				"Secret-Power",
				"Dive",
				"Rock-Tomb",
				"Tickle",
				"Muddy-Water",
				"Iron-Defense",
				"Mud-Shot",
				"Rock-Blast",
				"Water-Pulse",
				"Gyro-Ball",
				"Brine",
				"Natural-Gift",
				"Wring-Out",
				"Toxic-Spikes",
				"Rock-Polish",
				"Earth-Power",
				"Captivate",
				"Stealth-Rock",
				"Smack-Down",
				"Round",
				"Scald",
				"Shell-Smash",
				"Reflect-Type",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Omanyte PokemonInstance Class
	#region Omanyte
	public class OmanyteInstance : PokemonInstance
	{
		#region Omanyte Constructors
		/// <summary>
		/// Omanyte Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public OmanyteInstance(string nickname, int level)
		: base(
				SpeciesOmanyte.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Omanyte Builder only waiting for a Level
		/// </summary>
		public OmanyteInstance(int level)
		: base(
				SpeciesOmanyte.Instance, // PokemonInstance Species
				"Omanyte", level,
				Rock.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Omanyte Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public OmanyteInstance() : base(
			SpeciesOmanyte.Instance, // PokemonInstance Species
			Rock.Instance, Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}