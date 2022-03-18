using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Gyarados Species to store common natural stats of all Gyaradoss
	#region SpeciesGyarados
	public class SpeciesGyarados : PokemonSpecies
	{
#nullable enable
		private static SpeciesGyarados? _instance = null;
#nullable restore
        public static SpeciesGyarados Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGyarados();
                }
                return _instance;
            }
        }

		#region SpeciesGyarados Constructor
		public SpeciesGyarados() : base(
			130,
			"Gyarados",
			6.5,
			235.0,
			95, // HPs
			125, 79, // Attack & Defense
			60, 100, // Special Attack & Defense
			81		
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
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Leer",
				"Bite",
				"Roar",
				"Flamethrower",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Strength",
				"Dragon-Rage",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Reflect",
				"Bide",
				"Fire-Blast",
				"Waterfall",
				"Skull-Bash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Scary-Face",
				"Zap-Cannon",
				"Icy-Wind",
				"Outrage",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dragon-Breath",
				"Iron-Tail",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Crunch",
				"Rock-Smash",
				"Whirlpool",
				"Uproar",
				"Hail",
				"Torment",
				"Facade",
				"Taunt",
				"Secret-Power",
				"Dive",
				"Bounce",
				"Dragon-Dance",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Payback",
				"Dark-Pulse",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Giga-Impact",
				"Avalanche",
				"Ice-Fang",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Round",
				"Scald",
				"Incinerate",
				"Bulldoze",
				"Dragon-Tail",
				"Hurricane",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Gyarados PokemonInstance Class
	#region Gyarados
	public class GyaradosInstance : PokemonInstance
	{
		#region Gyarados Constructors
		/// <summary>
		/// Gyarados Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GyaradosInstance(string nickname, int level)
		: base(
				SpeciesGyarados.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gyarados Builder only waiting for a Level
		/// </summary>
		public GyaradosInstance(int level)
		: base(
				SpeciesGyarados.Instance, // PokemonInstance Species
				"Gyarados", level,
				Water.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gyarados Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public GyaradosInstance() : base(
			SpeciesGyarados.Instance, // PokemonInstance Species
			Water.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}