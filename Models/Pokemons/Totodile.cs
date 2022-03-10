using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Totodile Species to store common natural stats of all Totodiles
	#region SpeciesTotodile
	public class SpeciesTotodile : PokemonSpecies
	{
#nullable enable
		private static SpeciesTotodile? _instance = null;
#nullable restore
        public static SpeciesTotodile Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesTotodile();
                }
                return _instance;
            }
        }

		#region SpeciesTotodile Constructor
		public SpeciesTotodile() : base(
			"Totodile",
			0.6,
			9.5,
			50, // HPs
			65, 64, // Attack & Defense
			44, 48, // Special Attack & Defense
			43		
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
				"Scratch",
				"Razor-Wind",
				"Swords-Dance",
				"Cut",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Thrash",
				"Double-Edge",
				"Leer",
				"Bite",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Screech",
				"Double-Team",
				"Waterfall",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Curse",
				"Flail",
				"Spite",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Icy-Wind",
				"Detect",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Iron-Tail",
				"Metal-Claw",
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
				"Ancient-Power",
				"Whirlpool",
				"Uproar",
				"Hail",
				"Flatter",
				"Facade",
				"Focus-Punch",
				"Superpower",
				"Brick-Break",
				"Secret-Power",
				"Dive",
				"Mud-Sport",
				"Fake-Tears",
				"Rock-Tomb",
				"Aerial-Ace",
				"Block",
				"Dragon-Claw",
				"Water-Sport",
				"Dragon-Dance",
				"Water-Pulse",
				"Natural-Gift",
				"Fling",
				"Aqua-Tail",
				"Shadow-Claw",
				"Ice-Fang",
				"Captivate",
				"Aqua-Jet",
				"Hone-Claws",
				"Round",
				"Chip-Away",
				"Scald",
				"Water-Pledge",
				"Work-Up",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Totodile PokemonInstance Class
	#region Totodile
	public class TotodileInstance : PokemonInstance
	{
		#region Totodile Constructors
		/// <summary>
		/// Totodile Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TotodileInstance(string nickname, int level)
		: base(
				158,
				SpeciesTotodile.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Totodile Builder only waiting for a Level
		/// </summary>
		public TotodileInstance(int level)
		: base(
				158,
				SpeciesTotodile.Instance, // PokemonInstance Species
				"Totodile", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Totodile Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Totodile() : base(
			158,
			SpeciesTotodile.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}