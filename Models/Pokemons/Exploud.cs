using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Exploud Species to store common natural stats of all Explouds
	#region SpeciesExploud
	public class SpeciesExploud : PokemonSpecies
	{
#nullable enable
		private static SpeciesExploud? _instance = null;
#nullable restore
        public static SpeciesExploud Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesExploud();
                }
                return _instance;
            }
        }

		#region SpeciesExploud Constructor
		public SpeciesExploud() : base(
			295,
			"Exploud",
			1.5,
			84.0,
			104, // HPs
			91, 63, // Attack & Defense
			91, 73, // Special Attack & Defense
			68		
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
				"Pound",
				"Mega-Punch",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Stomp",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Bite",
				"Roar",
				"Supersonic",
				"Flamethrower",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Solar-Beam",
				"Earthquake",
				"Toxic",
				"Mimic",
				"Screech",
				"Double-Team",
				"Defense-Curl",
				"Fire-Blast",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Outrage",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Whirlpool",
				"Uproar",
				"Torment",
				"Facade",
				"Taunt",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Hyper-Voice",
				"Astonish",
				"Overheat",
				"Rock-Tomb",
				"Howl",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Fling",
				"Focus-Blast",
				"Giga-Impact",
				"Avalanche",
				"Thunder-Fang",
				"Ice-Fang",
				"Fire-Fang",
				"Zen-Headbutt",
				"Rock-Climb",
				"Captivate",
				"Smack-Down",
				"Synchronoise",
				"Round",
				"Echoed-Voice",
				"Incinerate",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Boomburst",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Exploud PokemonInstance Class
	#region Exploud
	public class ExploudInstance : PokemonInstance
	{
		#region Exploud Constructors
		/// <summary>
		/// Exploud Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ExploudInstance(string nickname, int level)
		: base(
				SpeciesExploud.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Exploud Builder only waiting for a Level
		/// </summary>
		public ExploudInstance(int level)
		: base(
				SpeciesExploud.Instance, // PokemonInstance Species
				"Exploud", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Exploud Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ExploudInstance() : base(
			SpeciesExploud.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}