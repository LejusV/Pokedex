using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Rayquaza Species to store common natural stats of all Rayquazas
	#region SpeciesRayquaza
	public class SpeciesRayquaza : PokemonSpecies
	{
#nullable enable
		private static SpeciesRayquaza? _instance = null;
#nullable restore
        public static SpeciesRayquaza Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesRayquaza();
                }
                return _instance;
            }
        }

		#region SpeciesRayquaza Constructor
		public SpeciesRayquaza() : base(
			384,
			"Rayquaza",
			7.0,
			206.5,
			105, // HPs
			150, 90, // Attack & Defense
			150, 90, // Special Attack & Defense
			95		
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
				"Fly",
				"Bind",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Roar",
				"Flamethrower",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Fire-Blast",
				"Waterfall",
				"Swift",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Icy-Wind",
				"Outrage",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Psych-Up",
				"Extreme-Speed",
				"Ancient-Power",
				"Rock-Smash",
				"Whirlpool",
				"Uproar",
				"Facade",
				"Brick-Break",
				"Secret-Power",
				"Dive",
				"Hyper-Voice",
				"Overheat",
				"Rock-Tomb",
				"Aerial-Ace",
				"Dragon-Claw",
				"Bulk-Up",
				"Dragon-Dance",
				"Shock-Wave",
				"Water-Pulse",
				"Gyro-Ball",
				"Natural-Gift",
				"Tailwind",
				"Fling",
				"Aqua-Tail",
				"Air-Slash",
				"Dragon-Pulse",
				"Focus-Blast",
				"Energy-Ball",
				"Earth-Power",
				"Giga-Impact",
				"Avalanche",
				"Shadow-Claw",
				"Draco-Meteor",
				"Iron-Head",
				"Stone-Edge",
				"Hone-Claws",
				"Round",
				"Echoed-Voice",
				"Sky-Drop",
				"Incinerate",
				"Bulldoze",
				"Dragon-Tail",
				"Confide",
				"Dragon-Ascent",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Rayquaza PokemonInstance Class
	#region Rayquaza
	public class RayquazaInstance : PokemonInstance
	{
		#region Rayquaza Constructors
		/// <summary>
		/// Rayquaza Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public RayquazaInstance(string nickname, int level)
		: base(
				SpeciesRayquaza.Instance, // Pokemon Species
				nickname, level,
				Dragon.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rayquaza Builder only waiting for a Level
		/// </summary>
		public RayquazaInstance(int level)
		: base(
				SpeciesRayquaza.Instance, // PokemonInstance Species
				"Rayquaza", level,
				Dragon.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rayquaza Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public RayquazaInstance() : base(
			SpeciesRayquaza.Instance, // PokemonInstance Species
			Dragon.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}