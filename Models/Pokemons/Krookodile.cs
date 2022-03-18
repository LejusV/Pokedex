using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Krookodile Species to store common natural stats of all Krookodiles
	#region SpeciesKrookodile
	public class SpeciesKrookodile : PokemonSpecies
	{
#nullable enable
		private static SpeciesKrookodile? _instance = null;
#nullable restore
        public static SpeciesKrookodile Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesKrookodile();
                }
                return _instance;
            }
        }

		#region SpeciesKrookodile Constructor
		public SpeciesKrookodile() : base(
			553,
			"Krookodile",
			1.5,
			96.3,
			95, // HPs
			117, 80, // Attack & Defense
			65, 70, // Special Attack & Defense
			92		
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
				"Sand-Attack",
				"Leer",
				"Bite",
				"Roar",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Rage",
				"Double-Team",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Scary-Face",
				"Sludge-Bomb",
				"Mud-Slap",
				"Outrage",
				"Sandstorm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Crunch",
				"Rock-Smash",
				"Uproar",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Superpower",
				"Brick-Break",
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Rock-Tomb",
				"Sand-Tomb",
				"Aerial-Ace",
				"Block",
				"Dragon-Claw",
				"Bulk-Up",
				"Payback",
				"Assurance",
				"Embargo",
				"Fling",
				"Dark-Pulse",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Shadow-Claw",
				"Stone-Edge",
				"Stealth-Rock",
				"Grass-Knot",
				"Hone-Claws",
				"Smack-Down",
				"Low-Sweep",
				"Foul-Play",
				"Round",
				"Incinerate",
				"Retaliate",
				"Bulldoze",
				"Dragon-Tail",
				"Snarl",
				"Confide",
				"Power-Up-Punch",
				"Power-Trip",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Krookodile PokemonInstance Class
	#region Krookodile
	public class KrookodileInstance : PokemonInstance
	{
		#region Krookodile Constructors
		/// <summary>
		/// Krookodile Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public KrookodileInstance(string nickname, int level)
		: base(
				SpeciesKrookodile.Instance, // Pokemon Species
				nickname, level,
				Ground.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Krookodile Builder only waiting for a Level
		/// </summary>
		public KrookodileInstance(int level)
		: base(
				SpeciesKrookodile.Instance, // PokemonInstance Species
				"Krookodile", level,
				Ground.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Krookodile Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public KrookodileInstance() : base(
			SpeciesKrookodile.Instance, // PokemonInstance Species
			Ground.Instance, Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}