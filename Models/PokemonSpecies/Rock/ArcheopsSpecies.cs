using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Archeops Species to store common natural stats of all Archeopss
	#region ArcheopsSpecies
	public class ArcheopsSpecies : PokemonSpecies
	{
#nullable enable
		private static ArcheopsSpecies? _instance = null;
#nullable restore
        public static ArcheopsSpecies Instance => _instance ?? (_instance = new ArcheopsSpecies());

		#region ArcheopsSpecies Constructor
		public ArcheopsSpecies() : base(
			567,
			"Archeops",
			Rock.Instance, Flying.Instance,
			1.4,
			32.0,
			new PokemonStats(
				75, // HPs
				140, 65, // Attack & Defense
				112, 65, // Spacial Attack & Defense
				110 // Speed
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
				"Cut",
				"Wing-Attack",
				"Fly",
				"Thrash",
				"Leer",
				"Roar",
				"Hyper-Beam",
				"Rock-Throw",
				"Earthquake",
				"Dig",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Double-Team",
				"Sky-Attack",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Scary-Face",
				"Outrage",
				"Sandstorm",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dragon-Breath",
				"Iron-Tail",
				"Hidden-Power",
				"Crunch",
				"Ancient-Power",
				"Rock-Smash",
				"Uproar",
				"Heat-Wave",
				"Torment",
				"Facade",
				"Taunt",
				"Knock-Off",
				"Endeavor",
				"Secret-Power",
				"Rock-Tomb",
				"Aerial-Ace",
				"Iron-Defense",
				"Dragon-Claw",
				"Bounce",
				"Roost",
				"Pluck",
				"Tailwind",
				"U-Turn",
				"Rock-Polish",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Shadow-Claw",
				"Zen-Headbutt",
				"Stone-Edge",
				"Stealth-Rock",
				"Hone-Claws",
				"Smack-Down",
				"Round",
				"Quick-Guard",
				"Acrobatics",
				"Bulldoze",
				"Dragon-Tail",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}