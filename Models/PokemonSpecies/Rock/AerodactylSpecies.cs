using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Aerodactyl Species to store common natural stats of all Aerodactyls
	#region AerodactylSpecies
	public class AerodactylSpecies : PokemonSpecies
	{
#nullable enable
		private static AerodactylSpecies? _instance = null;
#nullable restore
        public static AerodactylSpecies Instance => _instance ?? (_instance = new AerodactylSpecies());

		#region AerodactylSpecies Constructor
		public AerodactylSpecies() : base(
			142,
			"Aerodactyl",
			Rock.Instance, Flying.Instance,
			1.8,
			59.0,
			new PokemonStats(
				80, // HPs
				105, 65, // Attack & Defense
				60, 75, // Spacial Attack & Defense
				130 // Speed
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
				"Razor-Wind",
				"Wing-Attack",
				"Whirlwind",
				"Fly",
				"Headbutt",
				"Take-Down",
				"Double-Edge",
				"Bite",
				"Roar",
				"Supersonic",
				"Flamethrower",
				"Hyper-Beam",
				"Strength",
				"Dragon-Rage",
				"Earthquake",
				"Toxic",
				"Agility",
				"Rage",
				"Mimic",
				"Double-Team",
				"Reflect",
				"Bide",
				"Fire-Blast",
				"Swift",
				"Sky-Attack",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Scary-Face",
				"Foresight",
				"Detect",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dragon-Breath",
				"Pursuit",
				"Iron-Tail",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Ancient-Power",
				"Rock-Smash",
				"Heat-Wave",
				"Torment",
				"Facade",
				"Taunt",
				"Secret-Power",
				"Air-Cutter",
				"Rock-Tomb",
				"Aerial-Ace",
				"Dragon-Claw",
				"Roost",
				"Natural-Gift",
				"Tailwind",
				"Payback",
				"Assurance",
				"Rock-Polish",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Earth-Power",
				"Giga-Impact",
				"Thunder-Fang",
				"Ice-Fang",
				"Fire-Fang",
				"Defog",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Ominous-Wind",
				"Hone-Claws",
				"Wide-Guard",
				"Smack-Down",
				"Round",
				"Sky-Drop",
				"Incinerate",
				"Bulldoze",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}