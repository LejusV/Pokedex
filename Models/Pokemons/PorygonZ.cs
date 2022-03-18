using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Porygon-Z Species to store common natural stats of all Porygon-Zs
	#region SpeciesPorygon-Z
	public class SpeciesPorygonZ : PokemonSpecies
	{
#nullable enable
		private static SpeciesPorygonZ? _instance = null;
#nullable restore
        public static SpeciesPorygonZ Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPorygonZ();
                }
                return _instance;
            }
        }

		#region SpeciesPorygon-Z Constructor
		public SpeciesPorygonZ() : base(
			474,
			"Porygon-Z",
			0.9,
			34.0,
			85, // HPs
			80, 70, // Attack & Defense
			135, 75, // Special Attack & Defense
			90		
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
				"Tackle",
				"Ice-Beam",
				"Blizzard",
				"Psybeam",
				"Hyper-Beam",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Psychic",
				"Agility",
				"Double-Team",
				"Recover",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Conversion",
				"Tri-Attack",
				"Substitute",
				"Thief",
				"Snore",
				"Conversion-2",
				"Protect",
				"Zap-Cannon",
				"Icy-Wind",
				"Lock-On",
				"Endure",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Uproar",
				"Facade",
				"Trick",
				"Magic-Coat",
				"Recycle",
				"Secret-Power",
				"Signal-Beam",
				"Aerial-Ace",
				"Shock-Wave",
				"Gravity",
				"Natural-Gift",
				"Embargo",
				"Last-Resort",
				"Magnet-Rise",
				"Dark-Pulse",
				"Giga-Impact",
				"Nasty-Plot",
				"Zen-Headbutt",
				"Trick-Room",
				"Discharge",
				"Charge-Beam",
				"Wonder-Room",
				"Psyshock",
				"Foul-Play",
				"Round",
				"Electroweb",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Porygon-Z PokemonInstance Class
	#region Porygon-Z
	public class PorygonZInstance : PokemonInstance
	{
		#region Porygon-Z Constructors
		/// <summary>
		/// Porygon-Z Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PorygonZInstance(string nickname, int level)
		: base(
				SpeciesPorygonZ.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Porygon-Z Builder only waiting for a Level
		/// </summary>
		public PorygonZInstance(int level)
		: base(
				SpeciesPorygonZ.Instance, // PokemonInstance Species
				"Porygon-Z", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Porygon-Z Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public PorygonZInstance() : base(
			SpeciesPorygonZ.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}