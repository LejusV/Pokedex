using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Porygon Species to store common natural stats of all Porygons
	#region SpeciesPorygon
	public class SpeciesPorygon : PokemonSpecies
	{
#nullable enable
		private static SpeciesPorygon? _instance = null;
#nullable restore
        public static SpeciesPorygon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPorygon();
                }
                return _instance;
            }
        }

		#region SpeciesPorygon Constructor
		public SpeciesPorygon() : base(
			137,
			"Porygon",
			0.8,
			36.5,
			65, // HPs
			60, 70, // Attack & Defense
			85, 75, // Special Attack & Defense
			40		
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
				"Take-Down",
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
				"Rage",
				"Teleport",
				"Mimic",
				"Double-Team",
				"Recover",
				"Reflect",
				"Bide",
				"Swift",
				"Skull-Bash",
				"Dream-Eater",
				"Flash",
				"Psywave",
				"Rest",
				"Sharpen",
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

	//Porygon PokemonInstance Class
	#region Porygon
	public class PorygonInstance : PokemonInstance
	{
		#region Porygon Constructors
		/// <summary>
		/// Porygon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PorygonInstance(string nickname, int level)
		: base(
				SpeciesPorygon.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Porygon Builder only waiting for a Level
		/// </summary>
		public PorygonInstance(int level)
		: base(
				SpeciesPorygon.Instance, // PokemonInstance Species
				"Porygon", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Porygon Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public PorygonInstance() : base(
			SpeciesPorygon.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}