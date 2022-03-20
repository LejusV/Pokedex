using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Rayquaza Species to store common natural stats of all Rayquazas
	#region RayquazaSpecies
	public class RayquazaSpecies : PokemonSpecies
	{
#nullable enable
		private static RayquazaSpecies? _instance = null;
#nullable restore
        public static RayquazaSpecies Instance => _instance ?? (_instance = new RayquazaSpecies());

		#region RayquazaSpecies Constructor
		public RayquazaSpecies() : base(
			384,
			"Rayquaza",
			Dragon.Instance, Flying.Instance,
			7.0,
			206.5,
			new PokemonStats(
				105, // HPs
				150, 90, // Attack & Defense
				150, 90, // Spacial Attack & Defense
				95 // Speed
			)			
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
}