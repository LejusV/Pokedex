using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Carracosta Species to store common natural stats of all Carracostas
	#region SpeciesCarracosta
	public class SpeciesCarracosta : PokemonSpecies
	{
#nullable enable
		private static SpeciesCarracosta? _instance = null;
#nullable restore
        public static SpeciesCarracosta Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCarracosta();
                }
                return _instance;
            }
        }

		#region SpeciesCarracosta Constructor
		public SpeciesCarracosta() : base(
			565,
			"Carracosta",
			1.2,
			81.0,
			74, // HPs
			108, 133, // Attack & Defense
			83, 65, // Special Attack & Defense
			32		
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
				"Bite",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Double-Team",
				"Withdraw",
				"Bide",
				"Waterfall",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Icy-Wind",
				"Sandstorm",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
				"Ancient-Power",
				"Rock-Smash",
				"Facade",
				"Superpower",
				"Knock-Off",
				"Secret-Power",
				"Dive",
				"Rock-Tomb",
				"Iron-Defense",
				"Block",
				"Water-Pulse",
				"Brine",
				"Rock-Polish",
				"Aqua-Tail",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Zen-Headbutt",
				"Iron-Head",
				"Stone-Edge",
				"Stealth-Rock",
				"Aqua-Jet",
				"Wide-Guard",
				"Smack-Down",
				"Round",
				"Scald",
				"Shell-Smash",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Carracosta PokemonInstance Class
	#region Carracosta
	public class CarracostaInstance : PokemonInstance
	{
		#region Carracosta Constructors
		/// <summary>
		/// Carracosta Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CarracostaInstance(string nickname, int level)
		: base(
				SpeciesCarracosta.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Carracosta Builder only waiting for a Level
		/// </summary>
		public CarracostaInstance(int level)
		: base(
				SpeciesCarracosta.Instance, // PokemonInstance Species
				"Carracosta", level,
				Water.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Carracosta Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public CarracostaInstance() : base(
			SpeciesCarracosta.Instance, // PokemonInstance Species
			Water.Instance, Rock.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}