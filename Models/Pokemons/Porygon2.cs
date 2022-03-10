using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Porygon2 Species to store common natural stats of all Porygon2s
	#region SpeciesPorygon2
	public class SpeciesPorygon2 : PokemonSpecies
	{
#nullable enable
		private static SpeciesPorygon2? _instance = null;
#nullable restore
        public static SpeciesPorygon2 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPorygon2();
                }
                return _instance;
            }
        }

		#region SpeciesPorygon2 Constructor
		public SpeciesPorygon2() : base(
			"Porygon2",
			0.6,
			32.5,
			85, // HPs
			80, 90, // Attack & Defense
			105, 95, // Special Attack & Defense
			60		
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
				"Double-Edge",
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
				"Mimic",
				"Double-Team",
				"Recover",
				"Defense-Curl",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Conversion",
				"Tri-Attack",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
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
				"Last-Resort",
				"Magnet-Rise",
				"Giga-Impact",
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

	//Porygon2 PokemonInstance Class
	#region Porygon2
	public class Porygon2Instance : PokemonInstance
	{
		#region Porygon2 Constructors
		/// <summary>
		/// Porygon2 Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Porygon2Instance(string nickname, int level)
		: base(
				233,
				SpeciesPorygon2.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Porygon2 Builder only waiting for a Level
		/// </summary>
		public Porygon2Instance(int level)
		: base(
				233,
				SpeciesPorygon2.Instance, // PokemonInstance Species
				"Porygon2", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Porygon2 Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Porygon2() : base(
			233,
			SpeciesPorygon2.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}