using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Archen Species to store common natural stats of all Archens
	#region ArchenSpecies
	public class ArchenSpecies : PokemonSpecies
	{
#nullable enable
		private static ArchenSpecies? _instance = null;
#nullable restore
        public static ArchenSpecies Instance => _instance ?? (_instance = new ArchenSpecies());

		#region ArchenSpecies Constructor
		public ArchenSpecies() : base(
			566,
			"Archen",
			Rock.Instance, Flying.Instance,
			0.5,
			9.5,
			new PokemonStats(
				55, // HPs
				112, 45, // Attack & Defense
				74, 45, // Spacial Attack & Defense
				70 // Speed
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
				"Thrash",
				"Leer",
				"Bite",
				"Roar",
				"Rock-Throw",
				"Earthquake",
				"Dig",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Double-Team",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Scary-Face",
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
				"Earth-Power",
				"Switcheroo",
				"Shadow-Claw",
				"Zen-Headbutt",
				"Defog",
				"Stone-Edge",
				"Stealth-Rock",
				"Head-Smash",
				"Hone-Claws",
				"Smack-Down",
				"Round",
				"Quick-Guard",
				"Ally-Switch",
				"Acrobatics",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}