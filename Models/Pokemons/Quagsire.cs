using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Quagsire Species to store common natural stats of all Quagsires
	#region SpeciesQuagsire
	public class SpeciesQuagsire : PokemonSpecies
	{
#nullable enable
		private static SpeciesQuagsire? _instance = null;
#nullable restore
        public static SpeciesQuagsire Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesQuagsire();
                }
                return _instance;
            }
        }

		#region SpeciesQuagsire Constructor
		public SpeciesQuagsire() : base(
			195,
			"Quagsire",
			1.4,
			75.0,
			95, // HPs
			85, 85, // Attack & Defense
			65, 65, // Special Attack & Defense
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
				"Mega-Punch",
				"Ice-Punch",
				"Slam",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Tail-Whip",
				"Mist",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Haze",
				"Waterfall",
				"Amnesia",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Icy-Wind",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dynamic-Punch",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Ancient-Power",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Brick-Break",
				"Yawn",
				"Secret-Power",
				"Dive",
				"Mud-Sport",
				"Rock-Tomb",
				"Muddy-Water",
				"Mud-Shot",
				"Water-Pulse",
				"Natural-Gift",
				"Fling",
				"Aqua-Tail",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Mud-Bomb",
				"Stone-Edge",
				"Captivate",
				"Sludge-Wave",
				"After-You",
				"Round",
				"Scald",
				"Bulldoze",
				"Confide",
				"Infestation",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Quagsire PokemonInstance Class
	#region Quagsire
	public class QuagsireInstance : PokemonInstance
	{
		#region Quagsire Constructors
		/// <summary>
		/// Quagsire Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public QuagsireInstance(string nickname, int level)
		: base(
				SpeciesQuagsire.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Quagsire Builder only waiting for a Level
		/// </summary>
		public QuagsireInstance(int level)
		: base(
				SpeciesQuagsire.Instance, // PokemonInstance Species
				"Quagsire", level,
				Water.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Quagsire Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public QuagsireInstance() : base(
			SpeciesQuagsire.Instance, // PokemonInstance Species
			Water.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}