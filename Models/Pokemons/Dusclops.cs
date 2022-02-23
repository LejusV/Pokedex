using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Dusclops Specie to store common natural stats of every {'abilities': ['pressure', 'frisk'], 'base_experience': 159, 'height': 16, 'id': 356, 'moves': ['mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'bind', 'mega-kick', 'headbutt', 'body-slam', 'double-edge', 'leer', 'disable', 'ice-beam', 'blizzard', 'hyper-beam', 'counter', 'seismic-toss', 'strength', 'earthquake', 'toxic', 'psychic', 'night-shade', 'mimic', 'double-team', 'confuse-ray', 'metronome', 'dream-eater', 'flash', 'rest', 'rock-slide', 'substitute', 'thief', 'nightmare', 'snore', 'curse', 'spite', 'protect', 'mud-slap', 'foresight', 'icy-wind', 'endure', 'swagger', 'mean-look', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'dynamic-punch', 'pursuit', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'future-sight', 'rock-smash', 'torment', 'will-o-wisp', 'facade', 'focus-punch', 'taunt', 'trick', 'brick-break', 'skill-swap', 'snatch', 'secret-power', 'astonish', 'rock-tomb', 'shadow-punch', 'calm-mind', 'gravity', 'natural-gift', 'payback', 'embargo', 'fling', 'sucker-punch', 'dark-pulse', 'giga-impact', 'shadow-sneak', 'trick-room', 'captivate', 'charge-beam', 'ominous-wind', 'wonder-room', 'telekinesis', 'round', 'hex', 'bulldoze', 'confide', 'infestation', 'power-up-punch'], 'name': 'dusclops', 'stats': {'hp': 40, 'attack': 70, 'defense': 130, 'special-attack': 60, 'special-defense': 130, 'speed': 25}, 'types': ['ghost'], 'weight': 306, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 4, 'capture_rate': 90, 'color': 'black', 'shape': 'humanoid', 'habitat': 'forest', 'generation': 'generation-iii', 'growth_rate': 'fast', 'egg_groups': ['indeterminate'], 'names': {'ja-Hrkt': 'サマヨール', 'roomaji': 'Samayouru', 'ko': '미라몽', 'zh-Hant': '彷徨夜靈', 'fr': 'Téraclope', 'de': 'Zwirrklop', 'es': 'Dusclops', 'it': 'Dusclops', 'en': 'Dusclops', 'ja': 'サマヨール', 'zh-Hans': '彷徨夜灵'}, 'genera': {'ja-Hrkt': 'てまねきポケモン', 'ko': '손짓포켓몬', 'zh-Hant': '招手寶可夢', 'fr': 'Pokémon Appel', 'de': 'Wink', 'es': 'Pokémon Atrayente', 'it': 'Pokémon Ipnosguardo', 'en': 'Beckon Pokémon', 'ja': 'てまねきポケモン', 'zh-Hans': '招手宝可梦'}}
	public class SpecieDusclops : PokemonSpecie
	{
#nullable enable
		private static SpecieDusclops? _instance = null;
#nullable restore
        public static SpecieDusclops Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDusclops();
                }
                return _instance;
            }
        }

		public SpecieDusclops() : base(
			"Dusclops",
			40, // HPs
			70, 130, // Attack & Defense
			60, 130, // Special Attack & Defense
			25			
		) {}
	}


	//Dusclops Pokemon Class
	public class Dusclops : Pokemon
	{

		public Dusclops(string nickname, int level) : base(
			356,
			SpecieDusclops.Instance, // Pokemon Specie
			nickname, level,
			Ghost.Instance			
		) {}

		public Dusclops() : base(
			356,
			SpecieDusclops.Instance, // Pokemon Specie
			Ghost.Instance			
		) {}
	}
}