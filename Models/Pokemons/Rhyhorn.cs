using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Rhyhorn Species to store common natural stats of all Rhyhorns
	#region SpeciesRhyhorn
	public class SpeciesRhyhorn : PokemonSpecies
	{
#nullable enable
		private static SpeciesRhyhorn? _instance = null;
#nullable restore
        public static SpeciesRhyhorn Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesRhyhorn();
                }
                return _instance;
            }
        }

		#region SpeciesRhyhorn Constructor
		public SpeciesRhyhorn() : base(
			"Rhyhorn",
			1.0,
			115.0,
			80, // HPs
			85, 95, // Attack & Defense
			30, 30, // Special Attack & Defense
			25		
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
				"Stomp",
				"Headbutt",
				"Horn-Attack",
				"Fury-Attack",
				"Horn-Drill",
				"Body-Slam",
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Tail-Whip",
				"Leer",
				"Roar",
				"Flamethrower",
				"Ice-Beam",
				"Blizzard",
				"Counter",
				"Strength",
				"Thunderbolt",
				"Thunder",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Bide",
				"Fire-Blast",
				"Skull-Bash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Reversal",
				"Spite",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Zap-Cannon",
				"Icy-Wind",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Magnitude",
				"Megahorn",
				"Pursuit",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Ancient-Power",
				"Rock-Smash",
				"Uproar",
				"Facade",
				"Superpower",
				"Endeavor",
				"Secret-Power",
				"Crush-Claw",
				"Rock-Tomb",
				"Rock-Blast",
				"Shock-Wave",
				"Natural-Gift",
				"Metal-Burst",
				"Payback",
				"Rock-Polish",
				"Poison-Jab",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Dragon-Rush",
				"Earth-Power",
				"Thunder-Fang",
				"Ice-Fang",
				"Fire-Fang",
				"Rock-Climb",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Guard-Split",
				"Smack-Down",
				"Round",
				"Chip-Away",
				"Incinerate",
				"Bulldoze",
				"Drill-Run",
				"Rototiller",
				"Confide",
				"Smart-Strike"
			};
		}
		#endregion
	}
	#endregion

	//Rhyhorn PokemonInstance Class
	#region Rhyhorn
	public class RhyhornInstance : PokemonInstance
	{
		#region Rhyhorn Constructors
		/// <summary>
		/// Rhyhorn Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public RhyhornInstance(string nickname, int level)
		: base(
				111,
				SpeciesRhyhorn.Instance, // Pokemon Species
				nickname, level,
				Ground.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rhyhorn Builder only waiting for a Level
		/// </summary>
		public RhyhornInstance(int level)
		: base(
				111,
				SpeciesRhyhorn.Instance, // PokemonInstance Species
				"Rhyhorn", level,
				Ground.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rhyhorn Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Rhyhorn() : base(
			111,
			SpeciesRhyhorn.Instance, // PokemonInstance Species
			Ground.Instance, Rock.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}