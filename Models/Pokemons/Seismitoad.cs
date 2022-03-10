using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Seismitoad Species to store common natural stats of all Seismitoads
	#region SpeciesSeismitoad
	public class SpeciesSeismitoad : PokemonSpecies
	{
#nullable enable
		private static SpeciesSeismitoad? _instance = null;
#nullable restore
        public static SpeciesSeismitoad Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSeismitoad();
                }
                return _instance;
            }
        }

		#region SpeciesSeismitoad Constructor
		public SpeciesSeismitoad() : base(
			"Seismitoad",
			1.5,
			62.0,
			105, // HPs
			95, 75, // Attack & Defense
			85, 75, // Special Attack & Defense
			74		
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
				"Ice-Punch",
				"Growl",
				"Supersonic",
				"Acid",
				"Hydro-Pump",
				"Surf",
				"Bubble-Beam",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Double-Team",
				"Bubble",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Flail",
				"Protect",
				"Sludge-Bomb",
				"Icy-Wind",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Uproar",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Brick-Break",
				"Knock-Off",
				"Endeavor",
				"Secret-Power",
				"Hyper-Voice",
				"Rock-Tomb",
				"Muddy-Water",
				"Bounce",
				"Mud-Shot",
				"Water-Pulse",
				"Payback",
				"Fling",
				"Gastro-Acid",
				"Aqua-Ring",
				"Poison-Jab",
				"Drain-Punch",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Stealth-Rock",
				"Grass-Knot",
				"Venoshock",
				"Sludge-Wave",
				"After-You",
				"Round",
				"Echoed-Voice",
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

	//Seismitoad PokemonInstance Class
	#region Seismitoad
	public class SeismitoadInstance : PokemonInstance
	{
		#region Seismitoad Constructors
		/// <summary>
		/// Seismitoad Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SeismitoadInstance(string nickname, int level)
		: base(
				537,
				SpeciesSeismitoad.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Seismitoad Builder only waiting for a Level
		/// </summary>
		public SeismitoadInstance(int level)
		: base(
				537,
				SpeciesSeismitoad.Instance, // PokemonInstance Species
				"Seismitoad", level,
				Water.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Seismitoad Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Seismitoad() : base(
			537,
			SpeciesSeismitoad.Instance, // PokemonInstance Species
			Water.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}