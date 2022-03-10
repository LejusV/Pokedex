using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Loudred Species to store common natural stats of all Loudreds
	#region SpeciesLoudred
	public class SpeciesLoudred : PokemonSpecies
	{
#nullable enable
		private static SpeciesLoudred? _instance = null;
#nullable restore
        public static SpeciesLoudred Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesLoudred();
                }
                return _instance;
            }
        }

		#region SpeciesLoudred Constructor
		public SpeciesLoudred() : base(
			"Loudred",
			1.0,
			40.5,
			84, // HPs
			71, 43, // Attack & Defense
			71, 43, // Special Attack & Defense
			48		
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
				"Ice-Beam",
				"Blizzard",
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
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
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
				"Zen-Headbutt",
				"Captivate",
				"Smack-Down",
				"Synchronoise",
				"Round",
				"Echoed-Voice",
				"Incinerate",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Loudred PokemonInstance Class
	#region Loudred
	public class LoudredInstance : PokemonInstance
	{
		#region Loudred Constructors
		/// <summary>
		/// Loudred Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public LoudredInstance(string nickname, int level)
		: base(
				294,
				SpeciesLoudred.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Loudred Builder only waiting for a Level
		/// </summary>
		public LoudredInstance(int level)
		: base(
				294,
				SpeciesLoudred.Instance, // PokemonInstance Species
				"Loudred", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Loudred Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Loudred() : base(
			294,
			SpeciesLoudred.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}